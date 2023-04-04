using Godot;
using TumbleGD.Nodes.Spaces.Actuality;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Actuality.FromNodes;

public sealed class PhysicalOfSpace : ISpaceActuality
{
	public PhysicalOfSpace(IScalar<Node3D> node) =>
		this.node = node;
	
	public void Update() =>
		throw new NotImplementedException();

	private readonly IScalar<Node3D> node;
}