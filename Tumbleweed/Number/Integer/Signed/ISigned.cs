using Tumbleweed._Boolean;
using Tumbleweed.Number.Integer.Natural;

namespace Tumbleweed.Number.Integer.Signed;

public interface ISigned
{
	IBoolean IsPositive { get; }
	
	INatural Natural { get; }
}