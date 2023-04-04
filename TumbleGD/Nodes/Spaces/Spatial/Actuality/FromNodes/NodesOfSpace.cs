using Godot;
using TumbleGD.Nodes.Children;
using TumbleGD.Nodes.Spaces.Actuality;
using TumbleGD.Nodes.Spaces.Spatial.Entities.FromNodes.Nodes;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Actuality.FromNodes;

public sealed class NodesOfSpace : ISpaceActuality
{
	public NodesOfSpace(IScalar<Node3D> node)
	{
		current = new CurrentOfSpace(node);
		actual = new ActualOfSpace(node);
		children = new ChildrenOfNode(node);
	}

	public void Update()
	{
		foreach (Node entity in current) children.Remove(entity);
		foreach (Node entity in actual) children.Add(entity);
	}

	private readonly IEnumerable<Node> current;

	private readonly IEnumerable<Node> actual;
	
	private readonly ICollection<Node> children;
}