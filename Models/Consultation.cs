namespace Api.Models;

public class Consultation : ModelBase
{
  public string Reason { get; set; } = string.Empty;
  public ConsultationStatus Status { get; set; }
  public string Diagnosis { get; set; } = string.Empty;
  public string Observation { get; set; } = string.Empty;
  public DateTime DateSchedule { get; set; }

  public long ClinicId { get; set; }
  public Clinic Clinic { get; set; } = null!;

  public long VetId { get; set; }
  public User Vet { get; set; } = null!;

  public long PetId { get; set; }
  public Pet Pet { get; set; } = null!;
}

public enum ConsultationStatus
{
  Scheduled,
  InProcess,
  Completed,
  Canceled
}
