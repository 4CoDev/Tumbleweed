using System.Collections;
using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Children;

public sealed class ChildrenOfNode : IList<Node>
{
	public ChildrenOfNode(IScalar<Node> node) =>
		this.node = node;

	public IEnumerator<Node> GetEnumerator() =>
		node.Value.GetChildren().GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() =>
		GetEnumerator();

	public void Add(Node child) =>
		node.Value.AddChild(child);

	public void Clear()
	{
		foreach (Node child in this) Remove(child);
	}

	public Boolean Contains(Node child) =>
		node.Value.GetChildren().Contains(child);

	public void CopyTo(Node[] array, Int32 index) =>
		node.Value.GetChildren().CopyTo(array, index);

	public Boolean Remove(Node child)
	{
		Boolean contains = Contains(child);
		node.Value.RemoveChild(child);
		return contains;
	}

	public Int32 Count => node.Value.GetChildren().Count;

	public Boolean IsReadOnly =>
		node.Value.GetChildren().IsReadOnly;

	public Int32 IndexOf(Node hild) =>
		node.Value.GetChildren().IndexOf(hild);

	public void Insert(Int32 index, Node child)
	{
		node.Value.AddChild(child);
		node.Value.MoveChild(child, index);
	}

	public void RemoveAt(Int32 index)
	{
		Node child = node.Value.GetChild(index);
		node.Value.RemoveChild(child);
	}

	public Node this[Int32 index]
	{
		get => node.Value.GetChild(index);
		set
		{
			RemoveAt(index);
			Insert(index, value);
		}
	}

	private readonly IScalar<Node> node;
}