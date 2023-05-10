using Tumbleweed.Nullables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Storages.Elements;

public sealed class ElementOfScalar<T> : IStorageElement<T> where T : notnull
{
	public ElementOfScalar(IScalar<IStorageElement<T>> scalar) =>
		this.scalar = scalar;
	
	public INullable<T> Nullable =>
		scalar.Value.Nullable;

	public void Remove() =>
		scalar.Value.Remove();

	public void Place(T value) =>
		scalar.Value.Place(value);
	
	private readonly IScalar<IStorageElement<T>> scalar;
}