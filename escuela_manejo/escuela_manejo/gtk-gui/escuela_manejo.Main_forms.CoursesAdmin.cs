
// This file has been generated by the GUI designer. Do not modify.
namespace escuela_manejo.Main_forms
{
	public partial class CoursesAdmin
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action AgregarCursoAction;

		private global::Gtk.Action EliminarCursoAction;

		private global::Gtk.Action ModificarCursoAction;

		private global::Gtk.VBox vbox1;

		private global::Gtk.MenuBar menubar1;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget escuela_manejo.Main_forms.CoursesAdmin
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.AgregarCursoAction = new global::Gtk.Action("AgregarCursoAction", global::Mono.Unix.Catalog.GetString("Agregar Curso"), null, null);
			this.AgregarCursoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Agregar Curso");
			w1.Add(this.AgregarCursoAction, null);
			this.EliminarCursoAction = new global::Gtk.Action("EliminarCursoAction", global::Mono.Unix.Catalog.GetString("Eliminar Curso"), null, null);
			this.EliminarCursoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Eliminar Curso");
			w1.Add(this.EliminarCursoAction, null);
			this.ModificarCursoAction = new global::Gtk.Action("ModificarCursoAction", global::Mono.Unix.Catalog.GetString("Modificar Curso"), null, null);
			this.ModificarCursoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Modificar Curso");
			w1.Add(this.ModificarCursoAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "escuela_manejo.Main_forms.CoursesAdmin";
			this.Title = global::Mono.Unix.Catalog.GetString("CoursesAdmin");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child escuela_manejo.Main_forms.CoursesAdmin.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><menubar name=\'menubar1\'><menu name=\'AgregarCursoAction\' action=\'AgregarCurso" +
					"Action\'/><menu name=\'EliminarCursoAction\' action=\'EliminarCursoAction\'/><menu na" +
					"me=\'ModificarCursoAction\' action=\'ModificarCursoAction\'/></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add(this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			this.vbox1.Add(this.scrolledwindow1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.scrolledwindow1]));
			w3.Position = 1;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 685;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}
