
// This file has been generated by the GUI designer. Do not modify.
namespace Escuela_Manejo1
{
	public partial class Frm_instructor
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Frame frame1;

		private global::Gtk.Table table1;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.Alignment alignment4;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Entry txtApellidoI;

		private global::Gtk.Entry txtcorreoIn;

		private global::Gtk.Entry txtDireccionIn;

		private global::Gtk.Entry txtidIn;

		private global::Gtk.Entry txtNombreI;

		private global::Gtk.Entry txtTelefonoins;

		private global::Gtk.Label GtkLabel;

		private global::Gtk.Frame frame3;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Table table2;

		private global::Gtk.Button btnEDitarin;

		private global::Gtk.Button btnEliminarin;

		private global::Gtk.Button btnGuardarin;

		private global::Gtk.Button btnNuevoIns;

		private global::Gtk.Table table4;

		private global::Gtk.Button btnBuscarin;

		private global::Gtk.Entry txtBuscarIns;

		private global::Gtk.TreeView trwInstructor;

		private global::Gtk.Label GtkLabel7;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Escuela_Manejo1.Frm_instructor
			this.Name = "Escuela_Manejo1.Frm_instructor";
			this.Title = global::Mono.Unix.Catalog.GetString("Frm_instructor");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Escuela_Manejo1.Frm_instructor.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.WidthRequest = 700;
			this.frame1.HeightRequest = 150;
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frame1.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(4)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.table1.Add(this.alignment1);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.alignment1]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.LeftAttach = ((uint)(3));
			w1.RightAttach = ((uint)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.alignment2 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.table1.Add(this.alignment2);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.alignment2]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(2));
			w2.RightAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.alignment3 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.table1.Add(this.alignment3);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.alignment3]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.alignment4 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.table1.Add(this.alignment4);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.alignment4]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.LeftAttach = ((uint)(3));
			w4.RightAttach = ((uint)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("ID");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Apellido");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Correo");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Direccion");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Telefono");
			this.table1.Add(this.label6);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.label6]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.txtApellidoI = new global::Gtk.Entry();
			this.txtApellidoI.CanFocus = true;
			this.txtApellidoI.Name = "txtApellidoI";
			this.txtApellidoI.IsEditable = true;
			this.txtApellidoI.InvisibleChar = '•';
			this.table1.Add(this.txtApellidoI);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.txtApellidoI]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.txtcorreoIn = new global::Gtk.Entry();
			this.txtcorreoIn.CanFocus = true;
			this.txtcorreoIn.Name = "txtcorreoIn";
			this.txtcorreoIn.IsEditable = true;
			this.txtcorreoIn.InvisibleChar = '•';
			this.table1.Add(this.txtcorreoIn);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.txtcorreoIn]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.txtDireccionIn = new global::Gtk.Entry();
			this.txtDireccionIn.CanFocus = true;
			this.txtDireccionIn.Name = "txtDireccionIn";
			this.txtDireccionIn.IsEditable = true;
			this.txtDireccionIn.InvisibleChar = '•';
			this.table1.Add(this.txtDireccionIn);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.txtDireccionIn]));
			w13.LeftAttach = ((uint)(3));
			w13.RightAttach = ((uint)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.txtidIn = new global::Gtk.Entry();
			this.txtidIn.CanFocus = true;
			this.txtidIn.Name = "txtidIn";
			this.txtidIn.IsEditable = true;
			this.txtidIn.InvisibleChar = '•';
			this.table1.Add(this.txtidIn);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.txtidIn]));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.txtNombreI = new global::Gtk.Entry();
			this.txtNombreI.CanFocus = true;
			this.txtNombreI.Name = "txtNombreI";
			this.txtNombreI.IsEditable = true;
			this.txtNombreI.InvisibleChar = '•';
			this.table1.Add(this.txtNombreI);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.txtNombreI]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.txtTelefonoins = new global::Gtk.Entry();
			this.txtTelefonoins.CanFocus = true;
			this.txtTelefonoins.Name = "txtTelefonoins";
			this.txtTelefonoins.IsEditable = true;
			this.txtTelefonoins.InvisibleChar = '•';
			this.table1.Add(this.txtTelefonoins);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.txtTelefonoins]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(3));
			w16.RightAttach = ((uint)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			this.frame1.Add(this.table1);
			this.GtkLabel = new global::Gtk.Label();
			this.GtkLabel.Name = "GtkLabel";
			this.GtkLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Datos Personales</b>");
			this.GtkLabel.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel;
			this.fixed1.Add(this.frame1);
			global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.frame1]));
			w18.X = 3;
			w18.Y = 7;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.frame3 = new global::Gtk.Frame();
			this.frame3.WidthRequest = 800;
			this.frame3.HeightRequest = 480;
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frame3.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(1)), ((uint)(4)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.btnEDitarin = new global::Gtk.Button();
			this.btnEDitarin.WidthRequest = 85;
			this.btnEDitarin.CanFocus = true;
			this.btnEDitarin.Name = "btnEDitarin";
			this.btnEDitarin.UseUnderline = true;
			this.btnEDitarin.Label = global::Mono.Unix.Catalog.GetString("Editar");
			this.table2.Add(this.btnEDitarin);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2[this.btnEDitarin]));
			w19.LeftAttach = ((uint)(2));
			w19.RightAttach = ((uint)(3));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.btnEliminarin = new global::Gtk.Button();
			this.btnEliminarin.WidthRequest = 85;
			this.btnEliminarin.CanFocus = true;
			this.btnEliminarin.Name = "btnEliminarin";
			this.btnEliminarin.UseUnderline = true;
			this.btnEliminarin.Label = global::Mono.Unix.Catalog.GetString("Eliminar");
			this.table2.Add(this.btnEliminarin);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2[this.btnEliminarin]));
			w20.LeftAttach = ((uint)(3));
			w20.RightAttach = ((uint)(4));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.btnGuardarin = new global::Gtk.Button();
			this.btnGuardarin.WidthRequest = 85;
			this.btnGuardarin.CanFocus = true;
			this.btnGuardarin.Name = "btnGuardarin";
			this.btnGuardarin.UseUnderline = true;
			this.btnGuardarin.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.table2.Add(this.btnGuardarin);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2[this.btnGuardarin]));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.btnNuevoIns = new global::Gtk.Button();
			this.btnNuevoIns.WidthRequest = 85;
			this.btnNuevoIns.CanFocus = true;
			this.btnNuevoIns.Name = "btnNuevoIns";
			this.btnNuevoIns.UseUnderline = true;
			this.btnNuevoIns.Label = global::Mono.Unix.Catalog.GetString("Nuevo");
			this.table2.Add(this.btnNuevoIns);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2[this.btnNuevoIns]));
			w22.XOptions = ((global::Gtk.AttachOptions)(0));
			this.vbox1.Add(this.table2);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table2]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table4 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.btnBuscarin = new global::Gtk.Button();
			this.btnBuscarin.WidthRequest = 120;
			this.btnBuscarin.CanFocus = true;
			this.btnBuscarin.Name = "btnBuscarin";
			this.btnBuscarin.UseUnderline = true;
			this.btnBuscarin.Label = global::Mono.Unix.Catalog.GetString("Buscar");
			this.table4.Add(this.btnBuscarin);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table4[this.btnBuscarin]));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.txtBuscarIns = new global::Gtk.Entry();
			this.txtBuscarIns.CanFocus = true;
			this.txtBuscarIns.Name = "txtBuscarIns";
			this.txtBuscarIns.IsEditable = true;
			this.txtBuscarIns.InvisibleChar = '•';
			this.table4.Add(this.txtBuscarIns);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table4[this.txtBuscarIns]));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table4);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table4]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.trwInstructor = new global::Gtk.TreeView();
			this.trwInstructor.CanFocus = true;
			this.trwInstructor.Name = "trwInstructor";
			this.vbox1.Add(this.trwInstructor);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.trwInstructor]));
			w27.Position = 2;
			this.frame3.Add(this.vbox1);
			this.GtkLabel7 = new global::Gtk.Label();
			this.GtkLabel7.Name = "GtkLabel7";
			this.GtkLabel7.LabelProp = global::Mono.Unix.Catalog.GetString("<b></b>");
			this.GtkLabel7.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel7;
			this.fixed1.Add(this.frame3);
			global::Gtk.Fixed.FixedChild w29 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.frame3]));
			w29.X = 30;
			w29.Y = 155;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 985;
			this.DefaultHeight = 693;
			this.Show();
			this.btnNuevoIns.Clicked += new global::System.EventHandler(this.OnBtnNuevoInsClicked);
			this.btnGuardarin.Clicked += new global::System.EventHandler(this.OnBtnGuardarinClicked);
			this.btnEliminarin.Clicked += new global::System.EventHandler(this.OnBtnEliminarinClicked);
			this.btnEDitarin.Clicked += new global::System.EventHandler(this.OnBtnEDitarinClicked);
			this.btnBuscarin.Clicked += new global::System.EventHandler(this.OnBtnBuscarinClicked);
			this.trwInstructor.CursorChanged += new global::System.EventHandler(this.OnTrwInstructorCursorChanged);
		}
	}
}