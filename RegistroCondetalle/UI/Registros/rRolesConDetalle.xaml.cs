using RegistroCondetalle.BLL;
using RegistroCondetalle.Entidades;
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

namespace RegistroCondetalle.UI.Registros
{
    /// <summary>
    /// Interaction logic for rRolesConDetalle.xaml
    /// </summary>
    public partial class rRolesConDetalle : Window
    {
        private Roles rol = new Roles();

        public rRolesConDetalle()
        {
            InitializeComponent();
            this.DataContext = rol;

            PermisosComboBox.ItemsSource = PermisosBLL.GetPermisos();
            PermisosComboBox.SelectedValuePath = "PermisoId";
            PermisosComboBox.DisplayMemberPath = "Nombre";
        }

        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = rol;
        }
        private void Limpiar()
        {
            this.rol = new Roles();
            this.DataContext = rol;
        }

        private bool Validar()
        {
            bool esValido = true;
            if (PermisosComboBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Seleccione el permiso", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return esValido;
        }

        private bool ValidarGuardar()
        {
            bool esValido = true;
            if (DetalleDataGrid.Items.Count == 0)
            {
                esValido = false;
                MessageBox.Show("Roles no puede estar vacio, Debe agregar roles", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Roles encontrado = RolesBLL.Buscar(rol.RolId);

            if (encontrado != null)
            {
                rol = encontrado;
                Cargar();
            }
            else
            {
                Limpiar();
                MessageBox.Show("El Rol que intenta buuscar no existe", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            {
                rol.RolesDetalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Cargar();
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Roles esValido = RolesBLL.Buscar(rol.RolId);

            return (esValido != null);
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarGuardar())
                return;
            bool paso = false;
            paso = RolesBLL.Guardar(rol);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            Roles existe = RolesBLL.Buscar(rol.RolId);

            if (existe == null)
            {
                MessageBox.Show("No existe la tarea en la base de datos", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                RolesBLL.Eliminar(rol.RolId);
                MessageBox.Show("Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
            }
        }

        private void AgregarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            rol.RolesDetalle.Add(new RolesDetalle
            {
                RolId = rol.RolId,
                PermisoId = (int)PermisosComboBox.SelectedValue,
                esAsignado = true,
                PermisoDescripcion = ((Permisos)PermisosComboBox.SelectedItem).Descripcion
            });

            Cargar();
        }
    }
}
