public class ValidatorDate
{
    [FutureDate(ErrorMessage = "La fecha no puede ser en el futuro.")]
    public DateTime Fecha { get; set; }

}
