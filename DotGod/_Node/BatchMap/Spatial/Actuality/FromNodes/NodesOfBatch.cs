using DotGod._Node.BatchMap.Actuality;
using DotGod._Node.BatchMap.Spatial.Entities.FromNodes.Nodes;
using DotGod._Node.Children;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Node.BatchMap.Spatial.Actuality.FromNodes;

public sealed class NodesOfBatch : ISpaceActuality
{
	public NodesOfBatch(IScalar<Node3D> node)
	{
		current = new CurrentOfBatch(node);
		actual = new ActualOfBatch(node);
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