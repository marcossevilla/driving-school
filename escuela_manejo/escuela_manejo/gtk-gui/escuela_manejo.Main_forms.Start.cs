
// This file has been generated by the GUI designer. Do not modify.
namespace escuela_manejo.Main_forms
{
	public partial class Start
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Button button1;

		private global::Gtk.Button button2;

		private global::Gtk.Button button3;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget escuela_manejo.Main_forms.Start
			this.Name = "escuela_manejo.Main_forms.Start";
			this.Title = global::Mono.Unix.Catalog.GetString("Start");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child escuela_manejo.Main_forms.Start.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button1 = new global::Gtk.Button();
			this.button1.WidthRequest = 300;
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Pagos");
			this.fixed1.Add(this.button1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
			w1.X = 45;
			w1.Y = 58;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button2 = new global::Gtk.Button();
			this.button2.WidthRequest = 300;
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("Cursos");
			this.fixed1.Add(this.button2);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button2]));
			w2.X = 46;
			w2.Y = 126;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button3 = new global::Gtk.Button();
			this.button3.WidthRequest = 300;
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString("Seguridad");
			this.fixed1.Add(this.button3);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button3]));
			w3.X = 47;
			w3.Y = 200;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.button1.Clicked += new global::System.EventHandler(this.OnButtonPaymentClicked);
			this.button2.Clicked += new global::System.EventHandler(this.OnButtonCourseClicked);
			this.button3.Clicked += new global::System.EventHandler(this.OnButtonSecurityClicked);
		}
	}
}