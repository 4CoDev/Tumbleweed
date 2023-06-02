using DotGod._Node.Batch.Actuality;
using DotGod._Node.Children;
using DotGod.Spatial._Node.Batch.Entities.FromNodes.Nodes;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial._Node.Batch.Actuality.FromNodes;

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