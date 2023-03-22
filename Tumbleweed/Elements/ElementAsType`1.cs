using Tumbleweed.Nullability;

namespace Tumbleweed.Elements;

public sealed class ElementAsType<T> : IElement<T> where T : notnull
{
	public ElementAsType(IElement<Object> origin) =>
		this.origin = origin;
	
	public INullable<T> Value => new NullableAsType<T>(origin.Value);

	public void Remove() => origin.Remove();

	public void Create(T value) => origin.Create(value);
	
	private readonly IElement<Object> origin;
}