namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh.With.Surfaces;

public sealed class One : Any
{
	public One(IEnumerable<Graphical.Surface.Any> surfaces) =>
		Surfaces = surfaces;
	
	public IEnumerable<Graphical.Surface.Any> Surfaces { get; }
}