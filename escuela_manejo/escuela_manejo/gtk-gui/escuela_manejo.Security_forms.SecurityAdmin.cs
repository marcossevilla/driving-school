
// This file has been generated by the GUI designer. Do not modify.
namespace escuela_manejo.Security_forms
{
	public partial class SecurityAdmin
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action UsuariosAction;

		private global::Gtk.Action RolesAction;

		private global::Gtk.Action OpcionesAction;

		private global::Gtk.Action AgregarAction;

		private global::Gtk.Action ModificarYEliminarAction;

		private global::Gtk.Action AgregarAction1;

		private global::Gtk.Action ModificarYEliminarAction1;

		private global::Gtk.Action AgregarAction2;

		private global::Gtk.Action ModificarYEliminarAction2;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.MenuBar menubar1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget escuela_manejo.Security_forms.SecurityAdmin
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.UsuariosAction = new global::Gtk.Action("UsuariosAction", global::Mono.Unix.Catalog.GetString("Usuarios"), null, null);
			this.UsuariosAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Usuarios");
			w1.Add(this.UsuariosAction, null);
			this.RolesAction = new global::Gtk.Action("RolesAction", global::Mono.Unix.Catalog.GetString("Roles"), null, null);
			this.RolesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Roles");
			w1.Add(this.RolesAction, null);
			this.OpcionesAction = new global::Gtk.Action("OpcionesAction", global::Mono.Unix.Catalog.GetString("Opciones"), null, null);
			this.OpcionesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Opciones");
			w1.Add(this.OpcionesAction, null);
			this.AgregarAction = new global::Gtk.Action("AgregarAction", global::Mono.Unix.Catalog.GetString("Agregar"), null, null);
			this.AgregarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Agregar");
			w1.Add(this.AgregarAction, null);
			this.ModificarYEliminarAction = new global::Gtk.Action("ModificarYEliminarAction", global::Mono.Unix.Catalog.GetString("Modificar y Eliminar"), null, null);
			this.ModificarYEliminarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Modificar y Eliminar");
			w1.Add(this.ModificarYEliminarAction, null);
			this.AgregarAction1 = new global::Gtk.Action("AgregarAction1", global::Mono.Unix.Catalog.GetString("Agregar"), null, null);
			this.AgregarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Agregar");
			w1.Add(this.AgregarAction1, null);
			this.ModificarYEliminarAction1 = new global::Gtk.Action("ModificarYEliminarAction1", global::Mono.Unix.Catalog.GetString("Modificar y eliminar"), null, null);
			this.ModificarYEliminarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Modificar y eliminar");
			w1.Add(this.ModificarYEliminarAction1, null);
			this.AgregarAction2 = new global::Gtk.Action("AgregarAction2", global::Mono.Unix.Catalog.GetString("Agregar"), null, null);
			this.AgregarAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Agregar");
			w1.Add(this.AgregarAction2, null);
			this.ModificarYEliminarAction2 = new global::Gtk.Action("ModificarYEliminarAction2", global::Mono.Unix.Catalog.GetString("Modificar y eliminar"), null, null);
			this.ModificarYEliminarAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Modificar y eliminar");
			w1.Add(this.ModificarYEliminarAction2, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "escuela_manejo.Security_forms.SecurityAdmin";
			this.Title = global::Mono.Unix.Catalog.GetString("SecurityMain");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child escuela_manejo.Security_forms.SecurityAdmin.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.UIManager.AddUiFromString(@"<ui><menubar name='menubar1'><menu name='UsuariosAction' action='UsuariosAction'><menuitem name='AgregarAction' action='AgregarAction'/><menuitem name='ModificarYEliminarAction' action='ModificarYEliminarAction'/></menu><menu name='RolesAction' action='RolesAction'><menuitem name='AgregarAction1' action='AgregarAction1'/><menuitem name='ModificarYEliminarAction1' action='ModificarYEliminarAction1'/></menu><menu name='OpcionesAction' action='OpcionesAction'><menuitem name='AgregarAction2' action='AgregarAction2'/><menuitem name='ModificarYEliminarAction2' action='ModificarYEliminarAction2'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.fixed1.Add(this.menubar1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.menubar1]));
			w2.X = -2;
			w2.Y = 3;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 463;
			this.DefaultHeight = 300;
			this.Show();
			this.AgregarAction.Activated += new global::System.EventHandler(this.OnButtonAddUserClicked);
			this.ModificarYEliminarAction.Activated += new global::System.EventHandler(this.OnButtonModifyUserClicked);
		}
	}
}