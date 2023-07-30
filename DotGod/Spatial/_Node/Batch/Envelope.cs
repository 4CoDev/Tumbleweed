using DotGod.Spatial._Node.Batch.Entities;
using Tumbleweed.Scalar.Nullable;
using System = System;

namespace DotGod.Spatial._Node.Batch;

public abstract class Envelope : Batch.Any
{
	protected Envelope(Any batch) =>
		this.batch = batch;

	public override Boolean Equals(System::Object? @object) =>
		batch.Equals(@object);

	public override Int32 GetHashCode() =>
		batch.GetHashCode();

	public override System::String? ToString() =>
		batch.ToString();

	public Tumbleweed.Array.Any<Any<Batch.Any>> Subbatches =>
		batch.Subbatches;
	
	public ICollection<ISpatialEntity> Entities =>
		batch.Entities;

	private readonly Batch.Any batch;
}