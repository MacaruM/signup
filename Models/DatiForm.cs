

using System.ComponentModel.DataAnnotations;

public class DatiForm
{
    [Key]
    public string IdPrenotazione { get; set; }
    public string? Nome { get; set; }

    public string? Cognome { get; set; }

    public string? Email { get; set; }

    public DateOnly? DataDiNascita { get; set; }

    public string? Sesso{ get; set; }

    public string? Ruolo { get; set; }
}
  