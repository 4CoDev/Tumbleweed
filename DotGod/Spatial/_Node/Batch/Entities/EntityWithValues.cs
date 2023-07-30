using DotGod.Spatial._Node.Batch.Entities.Equality;
using DotGod.Spatial._Node.Batch.Space;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Tumbleweed.Scalar.Nullable;
using System = System;

namespace DotGod.Spatial._Node.Batch.Entities;

public sealed class EntityWithValues : ISpatialEntity
{
	public EntityWithValues
	(
		Any<Godot.Node> node,
		IMesh mesh, 
		ISpace size
	)
	{
		Node = node;
		Mesh = mesh;
		Occupation = size;
	}

	public override Boolean Equals(System::Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashFromObjects(Node, Mesh).Value;

	public override System::String ToString() =>
		new StringFromObjects(Node, Mesh).Value;

	public Any<Godot.Node> Node { get; }

	public IMesh Mesh { get; }

	public ISpace Occupation { get; }
}