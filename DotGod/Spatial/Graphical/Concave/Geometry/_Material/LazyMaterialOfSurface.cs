using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Lazy;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Material;

public sealed class LazyMaterialOfSurface : Envelope<Material>
{
	public LazyMaterialOfSurface(ISurface surface) : base
	(
		new OfValue<Material>(
			new MaterialOfSurface(surface))
	)
	{
	}
}