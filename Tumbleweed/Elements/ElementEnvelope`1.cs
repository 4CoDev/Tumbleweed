using Tumbleweed.Nullability;

namespace Tumbleweed.Elements;

public abstract class ElementEnvelope<T> : IElement<T> where T : notnull
{
	protected ElementEnvelope(IElement<T> element) =>
		this.element = element;

	public override Boolean Equals(Object? @object) =>
		element.Equals(@object);

	public override Int32 GetHashCode() =>
		element.GetHashCode();

	public override String? ToString() =>
		element.ToString();

	public INullable<T> Nullability => element.Nullability;

	public void Remove() => element.Remove();

	public void Create(T value) => element.Create(value);
	
	private readonly IElement<T> element;
}