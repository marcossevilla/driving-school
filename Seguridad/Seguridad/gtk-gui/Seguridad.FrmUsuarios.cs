
// This file has been generated by the GUI designer. Do not modify.
namespace Seguridad
{
	public partial class FrmUsuarios
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Label lblusuario;

		private global::Gtk.Label lblemail;

		private global::Gtk.Label lblrepitaClave;

		private global::Gtk.Label lblclave;

		private global::Gtk.Entry txtEmail;

		private global::Gtk.Entry txtRepitaClave;

		private global::Gtk.Entry txtNombre;

		private global::Gtk.Entry txtApellidos;

		private global::Gtk.Entry txtUsuario;

		private global::Gtk.Entry txtClave;

		private global::Gtk.Button btnEliminar;

		private global::Gtk.Button btnCancelar;

		private global::Gtk.Button btnGuardar;

		private global::Gtk.Entry txtBuscar;

		private global::Gtk.Button btnBuscar;

		private global::Gtk.Label label1;

		private global::Gtk.Label lblapellido;

		private global::Gtk.Label lblnombres;

		private global::Gtk.ScrolledWindow tvwUsuario;

		private global::Gtk.TreeView tvwUsuario1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Seguridad.FrmUsuarios
			this.WidthRequest = 860;
			this.HeightRequest = 620;
			this.Name = "Seguridad.FrmUsuarios";
			this.Title = global::Mono.Unix.Catalog.GetString("FrmUsuarios");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			// Container child Seguridad.FrmUsuarios.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lblusuario = new global::Gtk.Label();
			this.lblusuario.Name = "lblusuario";
			this.lblusuario.LabelProp = global::Mono.Unix.Catalog.GetString("Usuario:");
			this.fixed1.Add(this.lblusuario);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblusuario]));
			w1.X = 379;
			w1.Y = 79;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lblemail = new global::Gtk.Label();
			this.lblemail.Name = "lblemail";
			this.lblemail.LabelProp = global::Mono.Unix.Catalog.GetString("Correo electronico:");
			this.fixed1.Add(this.lblemail);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblemail]));
			w2.X = 14;
			w2.Y = 184;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lblrepitaClave = new global::Gtk.Label();
			this.lblrepitaClave.Name = "lblrepitaClave";
			this.lblrepitaClave.LabelProp = global::Mono.Unix.Catalog.GetString("Repita contrasena:");
			this.fixed1.Add(this.lblrepitaClave);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblrepitaClave]));
			w3.X = 373;
			w3.Y = 176;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lblclave = new global::Gtk.Label();
			this.lblclave.Name = "lblclave";
			this.lblclave.LabelProp = global::Mono.Unix.Catalog.GetString("Contrasena:");
			this.fixed1.Add(this.lblclave);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblclave]));
			w4.X = 377;
			w4.Y = 130;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txtEmail = new global::Gtk.Entry();
			this.txtEmail.CanFocus = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.IsEditable = true;
			this.txtEmail.InvisibleChar = '•';
			this.fixed1.Add(this.txtEmail);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txtEmail]));
			w5.X = 150;
			w5.Y = 176;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txtRepitaClave = new global::Gtk.Entry();
			this.txtRepitaClave.CanFocus = true;
			this.txtRepitaClave.Name = "txtRepitaClave";
			this.txtRepitaClave.IsEditable = true;
			this.txtRepitaClave.WidthChars = 30;
			this.txtRepitaClave.Visibility = false;
			this.txtRepitaClave.InvisibleChar = '•';
			this.fixed1.Add(this.txtRepitaClave);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txtRepitaClave]));
			w6.X = 509;
			w6.Y = 168;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txtNombre = new global::Gtk.Entry();
			this.txtNombre.CanFocus = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.IsEditable = true;
			this.txtNombre.InvisibleChar = '•';
			this.fixed1.Add(this.txtNombre);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txtNombre]));
			w7.X = 149;
			w7.Y = 84;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txtApellidos = new global::Gtk.Entry();
			this.txtApellidos.CanFocus = true;
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.IsEditable = true;
			this.txtApellidos.InvisibleChar = '•';
			this.fixed1.Add(this.txtApellidos);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txtApellidos]));
			w8.X = 148;
			w8.Y = 129;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txtUsuario = new global::Gtk.Entry();
			this.txtUsuario.CanFocus = true;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.IsEditable = true;
			this.txtUsuario.WidthChars = 30;
			this.txtUsuario.InvisibleChar = '•';
			this.fixed1.Add(this.txtUsuario);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txtUsuario]));
			w9.X = 510;
			w9.Y = 74;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txtClave = new global::Gtk.Entry();
			this.txtClave.CanFocus = true;
			this.txtClave.Name = "txtClave";
			this.txtClave.IsEditable = true;
			this.txtClave.WidthChars = 30;
			this.txtClave.Visibility = false;
			this.txtClave.InvisibleChar = '•';
			this.fixed1.Add(this.txtClave);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txtClave]));
			w10.X = 510;
			w10.Y = 122;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnEliminar = new global::Gtk.Button();
			this.btnEliminar.CanFocus = true;
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.UseUnderline = true;
			this.btnEliminar.Label = global::Mono.Unix.Catalog.GetString("Eliminar");
			this.fixed1.Add(this.btnEliminar);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnEliminar]));
			w11.X = 698;
			w11.Y = 207;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnCancelar = new global::Gtk.Button();
			this.btnCancelar.CanFocus = true;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.UseUnderline = true;
			this.btnCancelar.Label = global::Mono.Unix.Catalog.GetString("Cancelar");
			this.fixed1.Add(this.btnCancelar);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnCancelar]));
			w12.X = 620;
			w12.Y = 207;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnGuardar = new global::Gtk.Button();
			this.btnGuardar.CanFocus = true;
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.UseUnderline = true;
			this.btnGuardar.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.fixed1.Add(this.btnGuardar);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnGuardar]));
			w13.X = 545;
			w13.Y = 207;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txtBuscar = new global::Gtk.Entry();
			this.txtBuscar.CanFocus = true;
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.IsEditable = true;
			this.txtBuscar.WidthChars = 85;
			this.txtBuscar.InvisibleChar = '•';
			this.fixed1.Add(this.txtBuscar);
			global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txtBuscar]));
			w14.X = 21;
			w14.Y = 249;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnBuscar = new global::Gtk.Button();
			this.btnBuscar.WidthRequest = 80;
			this.btnBuscar.CanFocus = true;
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.UseUnderline = true;
			this.btnBuscar.Label = global::Mono.Unix.Catalog.GetString("Buscar");
			this.fixed1.Add(this.btnBuscar);
			global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnBuscar]));
			w15.X = 723;
			w15.Y = 248;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("CONTROL DE USUARIOS");
			this.fixed1.Add(this.label1);
			global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
			w16.X = 346;
			w16.Y = 16;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lblapellido = new global::Gtk.Label();
			this.lblapellido.Name = "lblapellido";
			this.lblapellido.LabelProp = global::Mono.Unix.Catalog.GetString("Apellidos:");
			this.fixed1.Add(this.lblapellido);
			global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblapellido]));
			w17.X = 16;
			w17.Y = 132;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lblnombres = new global::Gtk.Label();
			this.lblnombres.Name = "lblnombres";
			this.lblnombres.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre:");
			this.fixed1.Add(this.lblnombres);
			global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblnombres]));
			w18.X = 18;
			w18.Y = 85;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.tvwUsuario = new global::Gtk.ScrolledWindow();
			this.tvwUsuario.WidthRequest = 713;
			this.tvwUsuario.HeightRequest = 0;
			this.tvwUsuario.Name = "tvwUsuario";
			this.tvwUsuario.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child tvwUsuario.Gtk.Container+ContainerChild
			this.tvwUsuario1 = new global::Gtk.TreeView();
			this.tvwUsuario1.CanFocus = true;
			this.tvwUsuario1.Name = "tvwUsuario1";
			this.tvwUsuario.Add(this.tvwUsuario1);
			this.fixed1.Add(this.tvwUsuario);
			global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.tvwUsuario]));
			w20.X = 22;
			w20.Y = 291;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 860;
			this.DefaultHeight = 620;
			this.Show();
			this.btnEliminar.Clicked += new global::System.EventHandler(this.onELiminarCLicked);
			this.btnCancelar.Clicked += new global::System.EventHandler(this.onCancelarClicked);
			this.btnGuardar.Clicked += new global::System.EventHandler(this.onBtnGuardarClicked);
		}
	}
}
