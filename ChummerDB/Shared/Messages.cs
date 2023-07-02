namespace ChummerDB.Shared;

public record class ConvertHexToAsciiMessage(string HexToConvert);
public record class ConvertAsciiToHexMessage(string AsciiToConvert);