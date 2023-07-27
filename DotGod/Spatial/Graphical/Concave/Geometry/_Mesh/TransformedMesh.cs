using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh;

public sealed class TransformedMesh : MeshEnvelope
{
	public TransformedMesh
	(
		IMesh mesh,
		Transform3D transform
	) : this
	(
		mesh,
		new Tumbleweed.Scalar.Of.Value<Transform3D>(transform)
	)
	{
	}
	
	public TransformedMesh
	(
		IMesh mesh,
		Any<Transform3D> transform
	) : base
	(
		new MeshWithSurfaces(
			new TransformedSurfaces(
				new Result<ISurface>(
					() => mesh.Surfaces),
				transform))
	)
	{
	}
}