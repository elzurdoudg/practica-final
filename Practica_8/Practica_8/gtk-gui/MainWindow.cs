
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VPaned vpaned1;
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Fixed fixed2;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vpaned1 = new global::Gtk.VPaned ();
		this.vpaned1.CanFocus = true;
		this.vpaned1.Name = "vpaned1";
		this.vpaned1.Position = 112;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		this.vpaned1.Add (this.fixed1);
		global::Gtk.Paned.PanedChild w1 = ((global::Gtk.Paned.PanedChild)(this.vpaned1 [this.fixed1]));
		w1.Resize = false;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.fixed2 = new global::Gtk.Fixed ();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		this.vpaned1.Add (this.fixed2);
		this.Add (this.vpaned1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 561;
		this.DefaultHeight = 494;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
