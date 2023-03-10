using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes;

public sealed class TransformedMesh : MeshEnvelope
{
	public TransformedMesh
	(
		IMesh mesh,
		Transform3D transform
	) : this
	(
		mesh,
		new ScalarOfValue<Transform3D>(transform)
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
				new EnumerableOfDelegate<ISurface>(
					() => mesh.Surfaces),
				transform))
	)
	{
	}
}