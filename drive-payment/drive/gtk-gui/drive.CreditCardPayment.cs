
// This file has been generated by the GUI designer. Do not modify.
namespace drive
{
	public partial class CreditCardPayment
	{
		private global::Gtk.Fixed fixed7;

		private global::Gtk.Label lblDigits;

		private global::Gtk.Label lblName;

		private global::Gtk.Button btnClean;

		private global::Gtk.Button btnOK;

		private global::Gtk.Label lblExpDate;

		private global::Gtk.Entry entNameCard;

		private global::Gtk.Calendar calExpDate;

		private global::Gtk.Entry entCardNum;

		private global::Gtk.Label lblCreditCard;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget drive.CreditCardPayment
			this.Name = "drive.CreditCardPayment";
			this.Title = global::Mono.Unix.Catalog.GetString("CreditCardPayment");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child drive.CreditCardPayment.Gtk.Container+ContainerChild
			this.fixed7 = new global::Gtk.Fixed();
			this.fixed7.Name = "fixed7";
			this.fixed7.HasWindow = false;
			// Container child fixed7.Gtk.Fixed+FixedChild
			this.lblDigits = new global::Gtk.Label();
			this.lblDigits.Name = "lblDigits";
			this.lblDigits.LabelProp = global::Mono.Unix.Catalog.GetString("Numero de Tarjeta");
			this.fixed7.Add(this.lblDigits);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed7[this.lblDigits]));
			w1.X = 22;
			w1.Y = 74;
			// Container child fixed7.Gtk.Fixed+FixedChild
			this.lblName = new global::Gtk.Label();
			this.lblName.Name = "lblName";
			this.lblName.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre en tarjeta");
			this.fixed7.Add(this.lblName);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed7[this.lblName]));
			w2.X = 21;
			w2.Y = 116;
			// Container child fixed7.Gtk.Fixed+FixedChild
			this.btnClean = new global::Gtk.Button();
			this.btnClean.CanFocus = true;
			this.btnClean.Name = "btnClean";
			this.btnClean.UseUnderline = true;
			this.btnClean.Label = global::Mono.Unix.Catalog.GetString("Limpiar Campos");
			this.fixed7.Add(this.btnClean);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed7[this.btnClean]));
			w3.X = 66;
			w3.Y = 363;
			// Container child fixed7.Gtk.Fixed+FixedChild
			this.btnOK = new global::Gtk.Button();
			this.btnOK.CanFocus = true;
			this.btnOK.Name = "btnOK";
			this.btnOK.UseUnderline = true;
			this.btnOK.Label = global::Mono.Unix.Catalog.GetString("OK");
			this.fixed7.Add(this.btnOK);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed7[this.btnOK]));
			w4.X = 309;
			w4.Y = 363;
			// Container child fixed7.Gtk.Fixed+FixedChild
			this.lblExpDate = new global::Gtk.Label();
			this.lblExpDate.Name = "lblExpDate";
			this.lblExpDate.LabelProp = global::Mono.Unix.Catalog.GetString("Expira");
			this.fixed7.Add(this.lblExpDate);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed7[this.lblExpDate]));
			w5.X = 70;
			w5.Y = 157;
			// Container child fixed7.Gtk.Fixed+FixedChild
			this.entNameCard = new global::Gtk.Entry();
			this.entNameCard.CanFocus = true;
			this.entNameCard.Name = "entNameCard";
			this.entNameCard.IsEditable = true;
			this.entNameCard.InvisibleChar = '•';
			this.fixed7.Add(this.entNameCard);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed7[this.entNameCard]));
			w6.X = 159;
			w6.Y = 111;
			// Container child fixed7.Gtk.Fixed+FixedChild
			this.calExpDate = new global::Gtk.Calendar();
			this.calExpDate.CanFocus = true;
			this.calExpDate.Name = "calExpDate";
			this.calExpDate.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.fixed7.Add(this.calExpDate);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed7[this.calExpDate]));
			w7.X = 159;
			w7.Y = 155;
			// Container child fixed7.Gtk.Fixed+FixedChild
			this.entCardNum = new global::Gtk.Entry();
			this.entCardNum.CanFocus = true;
			this.entCardNum.Name = "entCardNum";
			this.entCardNum.IsEditable = true;
			this.entCardNum.InvisibleChar = '•';
			this.fixed7.Add(this.entCardNum);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed7[this.entCardNum]));
			w8.X = 159;
			w8.Y = 69;
			// Container child fixed7.Gtk.Fixed+FixedChild
			this.lblCreditCard = new global::Gtk.Label();
			this.lblCreditCard.Name = "lblCreditCard";
			this.lblCreditCard.LabelProp = global::Mono.Unix.Catalog.GetString("Pago con Tarjeta");
			this.fixed7.Add(this.lblCreditCard);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed7[this.lblCreditCard]));
			w9.X = 166;
			w9.Y = 22;
			this.Add(this.fixed7);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 477;
			this.DefaultHeight = 412;
			this.Show();
			this.btnClean.Clicked += new global::System.EventHandler(this.onClickBtnClean);
			this.btnOK.Clicked += new global::System.EventHandler(this.onClickBtnOK);
			this.calExpDate.DaySelected += new global::System.EventHandler(this.onDaySelected);
		}
	}
}
