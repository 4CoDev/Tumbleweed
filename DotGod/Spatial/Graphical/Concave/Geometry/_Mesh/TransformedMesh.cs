using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Godot;
using Tumbleweed._Enumerable;
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
		new ScalarValue<Transform3D>(transform)
	)
	{
	}
	
	public TransformedMesh
	(
		IMesh mesh,
		IScalar<Transform3D> transform
	) : base
	(
		new MeshWithSurfaces(
			new TransformedSurfaces(
				new EnumerableOfFunction<ISurface>(
					() => mesh.Surfaces),
				transform))
	)
	{
	}
}