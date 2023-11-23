using Tumbleweed.Mathematics.Boolean;
using Option = Tumbleweed.Property.Option;
using System = System;


namespace Tumbleweed.Property.Option;

public abstract class Envelope<T> : Option::Any<T>
{
	protected Envelope(Option::Any<T> option) =>
		this.option = option;

	public override System::Boolean Equals
	(
		System::Object? @object
	) =>
	(
		option.Equals(@object)
	);

	public override System::Int32 GetHashCode() =>
		option.GetHashCode();

	public override System::String? ToString() =>
		option.ToString();

	public T Value =>
		option.Value;

	public Any HasValue =>
		option.HasValue;
	
	private readonly Option::Any<T> option;
}