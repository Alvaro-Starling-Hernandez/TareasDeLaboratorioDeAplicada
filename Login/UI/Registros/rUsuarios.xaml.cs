using Login.BLL;
using Login.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Login.UI.Registros
{
    /// <summary>
    /// Interaction logic for rUsuarios.xaml
    /// </summary>
    public partial class rUsuarios : Window
    {
        Usuarios usuario = new Usuarios();

        public rUsuarios()
        {
            InitializeComponent();
            this.DataContext = usuario;
        }

        private void Limpiar()
        {
            this.usuario = new Usuarios();
            ContrasenaPasswordBox.Password = "";
            ConfirmarContrasenaPasswordBox.Password = "";
            this.DataContext = usuario;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (NombresTextBox.Text.Length == 0)
            {
                esValido = false;
                //GuardarButton.IsEnabled = false;
                MessageBox.Show("El campo Nombres está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                //NombresTextBox.Focus();
                //GuardarButton.IsEnabled = true;
            }

            if (ApellidosTextBox.Text.Length == 0)
            {
                esValido = false;
                //GuardarButton.IsEnabled = false;
                MessageBox.Show("El campo Apellidos está vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                //ApellidosTextBox.Focus();
                //GuardarButton.IsEnabled = true;
            }

            if (NombreUsuarioTextBox.Text.Length == 0)
            {
                esValido = false;
                GuardarButton.IsEnabled = false;
                MessageBox.Show("El campo Nombre usuario esta vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                //NombreUsuarioTextBox.Focus();
                //GuardarButton.IsEnabled = true;
            }

            if (ContrasenaPasswordBox.Password.Length == 0)
            {
                esValido = false;
               // GuardarButton.IsEnabled = false;
                MessageBox.Show("El campo Contraseña esta vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                //ContrasenaPasswordBox.Focus();
                //GuardarButton.IsEnabled = true;
            }

            if (ConfirmarContrasenaPasswordBox.Password.Length == 0)
            {
                esValido = false;
               // GuardarButton.IsEnabled = false;
                MessageBox.Show("El campo Confirmar contraseña esta vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                //ConfirmarContrasenaPasswordBox.Focus();
                //GuardarButton.IsEnabled = true;
            }

            if (ConfirmarContrasenaPasswordBox.Password != ContrasenaPasswordBox.Password)
            {
                esValido = false;
                GuardarButton.IsEnabled = false;
                MessageBox.Show("La contraseña no coiciden", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                ConfirmarContrasenaPasswordBox.Focus();
                GuardarButton.IsEnabled = true;
            }


            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var usuario = UsuariosBLL.Buscar(Convert.ToInt32(UsuarioIdTextBox.Text));

            if (usuario != null)
                this.usuario = usuario;
            else
                Limpiar();

            this.DataContext = this.usuario;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = UsuariosBLL.Guardar(usuario);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion exitosa!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsuariosBLL.Eliminar(Convert.ToInt32(UsuarioIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
