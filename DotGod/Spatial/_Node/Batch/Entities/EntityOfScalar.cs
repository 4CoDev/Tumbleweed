using DotGod.Spatial._Node.Batch.Entities.Equality;
using DotGod.Spatial._Node.Batch.Space;
using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Godot;
using Tumbleweed._Object.Hash;
using Tumbleweed._Object.String;
using Tumbleweed.Nullable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial._Node.Batch.Entities;

public sealed class EntityOfScalar : ISpatialEntity
{
	public EntityOfScalar(IScalar<ISpatialEntity> scalar) =>
		this.scalar = scalar;
	
	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashFromObjects(Node, Mesh).Value;

	public override String ToString() =>
		new StringFromObjects(Node, Mesh).Value;

	public INullable<Node> Node =>
		scalar.Value.Node;

	public IMesh Mesh =>
		scalar.Value.Mesh;

	public ISpace Occupation =>
		scalar.Value.Occupation;

	private readonly IScalar<ISpatialEntity> scalar;
}