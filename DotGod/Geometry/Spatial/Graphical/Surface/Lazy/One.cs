namespace DotGod.Geometry.Spatial.Graphical.Surface.Lazy;

public sealed class One : Envelope
{
	public One(Any surface) : base
	(
		new With.Members.One(
			new Polygon.Enumerable.Lazy(surface),
			new Material.Lazy(surface))
	)
	{
	}
}