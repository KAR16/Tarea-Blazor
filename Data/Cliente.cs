namespace webempresa.Data;

using System.Text.Json.Serialization;

public class Cliente{

    //Id Cliente
    [JsonPropertyName("id_cliente")]
    public Int32 Id_cliente {get; set;}

    //Nombres
    [JsonPropertyName("nombres")]
    public string? Nombres {get; set;}

    //Apellidos
    [JsonPropertyName("apellidos")]
    public string? Apellidos {get; set;}

    //Dirección
    [JsonPropertyName("direccion")]
    public string? Direccion {get; set;}

    //Teléfono
    [JsonPropertyName("telefono")]
    public string? Telefono {get; set;}

    //Fecha Nacimiento
    [JsonPropertyName("fecha_nacimiento")]
    public DateTime? Fecha_nacimiento {get; set;}

}