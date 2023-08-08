using Surface = DotGod.Geometry.Spatial.Concave.Graphical.Surface;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Mesh.With.Surfaces;

public sealed class One : Any
{
	public One(IEnumerable<Surface::Any> surfaces) =>
		Surfaces = surfaces;
	
	public IEnumerable<Surface::Any> Surfaces { get; }
}