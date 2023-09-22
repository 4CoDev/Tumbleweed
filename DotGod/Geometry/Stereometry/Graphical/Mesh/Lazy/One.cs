namespace DotGod.Geometry.Stereometry.Graphical.Mesh.Lazy;

public sealed class One : Envelope
{
	public One(Any mesh) : base
	(
		new With.Surfaces.One(
			new Surface.Enumerable.Lazy(mesh))
	)
	{
	}
}