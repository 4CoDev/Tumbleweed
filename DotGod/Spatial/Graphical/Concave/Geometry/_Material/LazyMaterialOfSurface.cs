using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Material;

public sealed class LazyMaterialOfSurface : ScalarEnvelope<Material>
{
	public LazyMaterialOfSurface(ISurface surface) : base
	(
		new LazyValue<Material>(
			new MaterialOfSurface(surface))
	)
	{
	}
}