using System;
using escuela_manejo.Data;
using escuela_manejo.business;
using System.Text;
using System.Collections.Generic;
using Gtk;

namespace escuela_manejo.Main_forms
{
    public partial class VehicleAdmin : Gtk.Window
    {
        DTvehicle dvehicle = new DTvehicle();
        BSvehicle bvehicle = new BSvehicle();
        escuela_manejo.Vehicle tvehicle = new escuela_manejo.Vehicle();
        StringBuilder sb = new StringBuilder();

        public VehicleAdmin() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

         
            CleanCombo();

            vehitreeview.Model = dvehicle.ListCourse();
            string[] titulos = { "Id Vehiculo", "Id Categoria", "Modelo", "Marca", "Placa", "Color", "Estado" };
            for (int i = 0; i < titulos.Length; i++)
            {
                vehitreeview.AppendColumn(titulos[i], new CellRendererText(), "text", i);

            }

        }


        protected void OnTvwVehicleCursorChanged(object sender, EventArgs e)
        {


            TreeSelection seleccion = (sender as TreeView).Selection;
            TreeIter iter;
            TreeModel model;
            if (seleccion.GetSelected(out model, out iter))
            {
                tvehicle.Id_vehicle = Convert.ToInt32(model.GetValue(iter, 0).ToString());
                this.txtcategory.Text = model.GetValue(iter, 1).ToString();
                this.txtmodel.Text = model.GetValue(iter, 2).ToString();
                this.txtbrand.Text = model.GetValue(iter, 3).ToString();
                this.txtplate.Text = model.GetValue(iter, 4).ToString();
                this.txtcolor.Text = model.GetValue(iter, 5).ToString();
                

            }
        }

        protected void OnBtnGuardarClicked(object sender, EventArgs e)
        {
            if (txtcategory.Text.Equals("") || txtmodel.Text.Equals("") | txtbrand.Text.Equals("") | txtplate.Text.Equals("") | txtcolor.Text.Equals("") | statecombo.Active.Equals(""))
            {
               var ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Error, ButtonsType.Ok, "Todos los campos son requeridos!!!");
                ms.Run();
                ms.Destroy();
            }
            else
            {
                tvehicle.Id_category  = Convert.ToInt32(txtcategory.Text);
                tvehicle.Model = this.txtmodel.Text;
                tvehicle.Brand = this.txtbrand.Text;
                tvehicle.Plate = this.txtplate.Text;
                tvehicle.Color = this.txtcolor.Text;
                tvehicle.State = Convert.ToInt32(statecombo.Active);

                if (bvehicle.BSsavevehicle(tvehicle))
                {
                    if (dvehicle.SaveVehicle(tvehicle)) {  
                    var ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Info, ButtonsType.Ok, "Se guardo el vehiculo con exito!!!");
                        ms.Run();
                        ms.Destroy();
                        CleanEntries();
                        vehitreeview.Model = dvehicle.ListCourse();
                    }
                    else
                    {

                        var ms = new MessageDialog(null, DialogFlags.Modal,
                            MessageType.Error, ButtonsType.Ok, "Revise los datos e intente nuevamente!!!");
                        ms.Run();
                        ms.Destroy();
                        this.txtcategory.GrabFocus();
                    }
                }

                else
                {

                    var ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Error, ButtonsType.Ok, "Revise los datos e intente nuevamente!!!");
                    ms.Run();
                    ms.Destroy();
                    this.txtcategory.GrabFocus();
                }
            }

        }

        protected void OnBtnEliminarClicked(object sender, EventArgs e)
        {
            int delete = 0;
            delete = dvehicle.DeleteVehicle(tvehicle);
            if (delete != 0)
            {
                var ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Info, ButtonsType.Ok, "Vehiculo eliminado con exito!!!");
                ms.Run();
                ms.Destroy();
                CleanEntries();
                vehitreeview.Model = dvehicle.ListCourse();
            }
            else
            {
               var ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Error, ButtonsType.Ok, "Por favor selecione un vehiculo e intente nuevamente!!!");
                ms.Run();
                ms.Destroy();
            }
        }

        public void CleanEntries()
        {
            txtcategory.Text = "";
            txtmodel.Text = "";
            txtbrand.Text = "";
            txtplate.Text = "";
            txtcolor.Text = "";

        }//fin del metodo


        protected void onClickBtnClean(object sender, EventArgs e)
        {
            CleanEntries();
        }//fin del metodo


        protected void OnBtnBuscarClicked(object sender, EventArgs e)
        {
            String search = "";
            search = this.txtbuscar.Text.Trim();
            vehitreeview.Model = dvehicle.SearchVehi(search);
        }


        public void FillComboState()
        {
            List<escuela_manejo.Vehicle> listState = new List<escuela_manejo.Vehicle>();
            listState = dvehicle.cbxState();

            statecombo.InsertText(0, "Seleccione...");

            foreach ( escuela_manejo.Vehicle vehicle in listState)
            {
                statecombo.InsertText(vehicle.Id_vehicle, vehicle.Plate);
            }

        }


        public void CleanCombo()
        {
            //POSICIONAMOS EL COMBO EN LA POSICION 0
            this.statecombo.Active = 0;
           
        }

        public void RestartTable(object sender, EventArgs e)
        {
            vehitreeview.Model = dvehicle.ListCourse();

        }



    }


}

