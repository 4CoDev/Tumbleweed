using DotGod._Node.BatchMap.Actuality;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.BatchMap.Spatial.Actuality.FromNodes;

public sealed class PhysicalOfBatch : ISpaceActuality
{
	public PhysicalOfBatch(IScalar<Node3D> node) =>
		this.node = node;
	
	public void Update() =>
		throw new NotImplementedException();

	private readonly IScalar<Node3D> node;
}