using DotGod.Spatial._Node.Batch.Entities.Equality;
using DotGod.Spatial._Node.Batch.Space;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Godot;
using Tumbleweed._Object.Hash;
using Tumbleweed._Object.String;
using Tumbleweed.Nullable;

namespace DotGod.Spatial._Node.Batch.Entities;

public sealed class EntityWithValues : ISpatialEntity
{
	public EntityWithValues
	(
		INullable<Node> node,
		IMesh mesh, 
		ISpace size
	)
	{
		Node = node;
		Mesh = mesh;
		Occupation = size;
	}

	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashFromObjects(Node, Mesh).Value;

	public override String ToString() =>
		new StringFromObjects(Node, Mesh).Value;

	public INullable<Node> Node { get; }

	public IMesh Mesh { get; }

	public ISpace Occupation { get; }
}