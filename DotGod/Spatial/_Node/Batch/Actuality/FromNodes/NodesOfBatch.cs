using DotGod._Node.Batch.Actuality;
using DotGod._Node.Children;
using DotGod.Spatial._Node.Batch.Entities.FromNodes.Nodes;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial._Node.Batch.Actuality.FromNodes;

public sealed class NodesOfBatch : ISpaceActuality
{
	public NodesOfBatch(Any<Node3D> node)
	{
		current = new CurrentOfBatch(node);
		actual = new ActualOfBatch(node);
		children = new ChildrenOfNode(node);
	}

	public void Update()
	{
		foreach (Godot.Node entity in current) children.Remove(entity);
		foreach (Godot.Node entity in actual) children.Add(entity);
	}

	private readonly IEnumerable<Godot.Node> current;

	private readonly IEnumerable<Godot.Node> actual;
	
	private readonly ICollection<Godot.Node> children;
}