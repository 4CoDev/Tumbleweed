using Godot;
using TumbleGD.Geometrics.Graphical.Meshes;
using TumbleGD.Geometrics.Graphical.Surfaces;
using TumbleGD.Nodes.Spaces.Spatial.Entities.Equality;
using Tumbleweed.Hashes;
using Tumbleweed.Nullability;
using Tumbleweed.Scalars;
using Tumbleweed.Strings.FromObjects;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities;

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

	private readonly IScalar<ISpatialEntity> scalar;
}