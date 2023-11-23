using Output = Tumbleweed.Property.Output;
using Option = Tumbleweed.Property.Option;

namespace Tumbleweed.Property.Option.Spare.When.Null;

public sealed class One<T> : Output::Envelope<T>
{
	public One
	(
		Option::Any<T> option,
		T spare
	) : this
	(
		option,
		new Output::With.Value.One<T>(spare)
	)
	{
	}
	
	public One
	(
		Option::Any<T> option,
		Output::Any<T> spare
	) : base
	(
		new Output::Function.Result.Actual<T>(
			() => Function(option, spare))
	)
	{
	}

	private static T Function
	(
		Option::Any<T> option,
		Output::Any<T> spare
	)
	{
		if (option.HasValue.State) return option.Value;
		return spare.Value;
	}
}