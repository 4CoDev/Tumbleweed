using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Material;

public sealed class LazyMaterialOfSurface : Envelope<Material>
{
	public LazyMaterialOfSurface(ISurface surface) : base
	(
		new Tumbleweed.Scalar.Immutable.Lazy<Material>(
			new MaterialOfSurface(surface))
	)
	{
	}
}