using Tumbleweed.Scalar.Nullable;
using System = System;

namespace DotGod.Node.Batch.Dimension.Spatial.Unspaced;

public abstract class Envelope : Any
{
	protected Envelope(Any batch) =>
		this.batch = batch;

	public override Boolean Equals(System::Object? @object) =>
		batch.Equals(@object);

	public override Int32 GetHashCode() =>
		batch.GetHashCode();

	public override System::String? ToString() =>
		batch.ToString();

	public Tumbleweed.Array.Any<Any<Any>> Subbatches =>
		batch.Subbatches;
	
	public ICollection<Entity.Any> Entities =>
		batch.Entities;

	private readonly Any batch;
}