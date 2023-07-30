using DotGod._Node.Batch.Actuality;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial._Node.Batch.Actuality.FromNodes;

public sealed class PhysicalOfBatch : ISpaceActuality
{
	public PhysicalOfBatch(Any<Node3D> node) =>
		this.node = node;
	
	public void Update() =>
		throw new NotImplementedException();

	private readonly Any<Node3D> node;
}