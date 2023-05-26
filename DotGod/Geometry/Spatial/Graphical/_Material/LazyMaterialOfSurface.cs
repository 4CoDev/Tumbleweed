using DotGod.Geometry.Spatial.Graphical.Surface;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical._Material;

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