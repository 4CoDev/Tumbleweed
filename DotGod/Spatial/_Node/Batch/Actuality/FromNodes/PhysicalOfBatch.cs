using DotGod._Node.Batch.Actuality;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial._Node.Batch.Actuality.FromNodes;

public sealed class PhysicalOfBatch : ISpaceActuality
{
	public PhysicalOfBatch(IScalar<Node3D> node) =>
		this.node = node;
	
	public void Update() =>
		throw new NotImplementedException();

	private readonly IScalar<Node3D> node;
}