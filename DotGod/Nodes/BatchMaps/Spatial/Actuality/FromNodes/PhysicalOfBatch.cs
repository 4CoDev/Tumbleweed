using DotGod.Nodes.BatchMaps.Actuality;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Actuality.FromNodes;

public sealed class PhysicalOfBatch : ISpaceActuality
{
	public PhysicalOfBatch(IScalar<Node3D> node) =>
		this.node = node;
	
	public void Update() =>
		throw new NotImplementedException();

	private readonly IScalar<Node3D> node;
}