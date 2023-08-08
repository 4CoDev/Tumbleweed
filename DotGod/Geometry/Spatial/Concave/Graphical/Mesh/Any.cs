using Surface = DotGod.Geometry.Spatial.Concave.Graphical.Surface;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Mesh;

public interface Any
{
	IEnumerable<Surface::Any> Surfaces { get; }
}