using System.Collections;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Member.Children;

public sealed class Actual : IList<Godot.Node>
{
	public Actual(Godot.Node parent) : this
	(
		new Value<Godot.Node>(parent)
	)
	{
	}

	public Actual(Any<Godot.Node> parent) =>
		this.parent = parent;

	public IEnumerator<Godot.Node> GetEnumerator() =>
		parent.Value.GetChildren().GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() =>
		GetEnumerator();

	public void Add(Godot.Node child) =>
		parent.Value.AddChild(child);

	public void Clear()
	{
		foreach (Godot.Node child in this) Remove(child);
	}

	public Boolean Contains(Godot.Node child) =>
		parent.Value.GetChildren().Contains(child);

	public void CopyTo(Godot.Node[] array, Int32 index) =>
		parent.Value.GetChildren().CopyTo(array, index);

	public Boolean Remove(Godot.Node child)
	{
		Boolean contains = Contains(child);
		parent.Value.RemoveChild(child);
		return contains;
	}

	public Int32 Count => parent.Value.GetChildren().Count;

	public Boolean IsReadOnly =>
		parent.Value.GetChildren().IsReadOnly;

	public Int32 IndexOf(Godot.Node hild) =>
		parent.Value.GetChildren().IndexOf(hild);

	public void Insert(Int32 index, Godot.Node child)
	{
		parent.Value.AddChild(child);
		parent.Value.MoveChild(child, index);
	}

	public void RemoveAt(Int32 index)
	{
		Godot.Node child = parent.Value.GetChild(index);
		parent.Value.RemoveChild(child);
	}

	public Godot.Node this[Int32 index]
	{
		get => parent.Value.GetChild(index);
		set
		{
			RemoveAt(index);
			Insert(index, value);
		}
	}

	private readonly Any<Godot.Node> parent;
}