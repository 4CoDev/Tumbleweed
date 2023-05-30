using DotGod.Spatial.Graphical.Concave.Geometry.Surface;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh;

public interface IMesh
{
	IEnumerable<ISurface> Surfaces { get; }
}