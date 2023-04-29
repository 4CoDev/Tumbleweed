using System.Collections;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.Children;

public sealed class ChildrenOfNode : IList<Node>
{
	public ChildrenOfNode(Node parent) : this
	(
		new ScalarValue<Node>(parent)
	)
	{
	}

	public ChildrenOfNode(IScalar<Node> parent) =>
		this.parent = parent;

	public IEnumerator<Node> GetEnumerator() =>
		parent.Value.GetChildren().GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() =>
		GetEnumerator();

	public void Add(Node child) =>
		parent.Value.AddChild(child);

	public void Clear()
	{
		foreach (Node child in this) Remove(child);
	}

	public Boolean Contains(Node child) =>
		parent.Value.GetChildren().Contains(child);

	public void CopyTo(Node[] array, Int32 index) =>
		parent.Value.GetChildren().CopyTo(array, index);

	public Boolean Remove(Node child)
	{
		Boolean contains = Contains(child);
		parent.Value.RemoveChild(child);
		return contains;
	}

	public Int32 Count => parent.Value.GetChildren().Count;

	public Boolean IsReadOnly =>
		parent.Value.GetChildren().IsReadOnly;

	public Int32 IndexOf(Node hild) =>
		parent.Value.GetChildren().IndexOf(hild);

	public void Insert(Int32 index, Node child)
	{
		parent.Value.AddChild(child);
		parent.Value.MoveChild(child, index);
	}

	public void RemoveAt(Int32 index)
	{
		Node child = parent.Value.GetChild(index);
		parent.Value.RemoveChild(child);
	}

	public Node this[Int32 index]
	{
		get => parent.Value.GetChild(index);
		set
		{
			RemoveAt(index);
			Insert(index, value);
		}
	}

	private readonly IScalar<Node> parent;
}