select t.TurnoID Turno, p.Nombre, p.Apellido, e.Nombre Nombre_Medico, e.Apellido Apellido_Medico, ms.IdSala Sala, tc.tipo TipoConsulta, hc.fechahora HComun, t.Estado, t.Asistido from TurnoConsultaExterna t,paciente p, empleado e,medico m, MedicoSala ms, TipoConsultaExterna tc,HorarioConsultaComun hc where ((t.Idpaciente = p.IdPaciente) and (t.idSalaMedico = ms.idSalaMedico) and (ms.IdMedico = m.IdMedico) and (t.TipoConsultaExterna = tc.tipoID) and (e.idEmpleado = m.idEmpleado) and (t.idhorariocomun = hc.idhorariocomun)) group by t.turnoID

select t.TurnoID Turno, p.Nombre, p.Apellido, e.Nombre Nombre_Medico, e.Apellido Apellido_Medico, ms.IdSala Sala, tc.tipo TipoConsulta, hs.fechahora HSaludM, t.Estado, t.Asistido from TurnoConsultaExterna t,paciente p, empleado e,medico m, MedicoSala ms, TipoConsultaExterna tc,HorarioSaludMentalCE hs  where ((t.Idpaciente = p.IdPaciente) and (t.idSalaMedico = ms.idSalaMedico) and (ms.IdMedico = m.IdMedico) and (t.TipoConsultaExterna = tc.tipoID) and (e.idEmpleado = m.idEmpleado) and (t.idhorarioSM = hs.idhorarioSM)) group by t.turnoID

select t.TurnoID Turno, p.Nombre, p.Apellido, e.Nombre Nombre_Medico, e.Apellido Apellido_Medico, ms.IdSala Sala, tc.tipo TipoConsulta, hf.fechahora HFisiok, t.Estado, t.Asistido from TurnoConsultaExterna t,paciente p, empleado e,medico m, MedicoSala ms, TipoConsultaExterna tc, HorarioFisiokinesiologiaCE hf where ((t.Idpaciente = p.IdPaciente) and (t.idSalaMedico = ms.idSalaMedico) and (ms.IdMedico = m.IdMedico) and (t.TipoConsultaExterna = tc.tipoID) and (e.idEmpleado = m.idEmpleado) and (t.idhorariofisio = hf.idhorarioFisio)) group by t.turnoID


insert into TurnoConsultaExterna values
('', 1, 1, NULL, 1, 0, NULL, NULL, NULL);

select idHorarioComun
from HorarioConsultaComun
where(fechahora = '2018/01/01 17:15')

insert into TurnoConsultaExterna values
('', 1, 1, NULL, 1, 0, 1, NULL, NULL)

select fechahora
from HorarioConsultaComun hcc
where idHorarioComun not in(
select idHorarioComun
from TurnoConsultaExterna
where(estado = 1))
and idHorarioComun is not null

select max(turnoid)
from TurnoConsultaExterna
limit 1

select count(*)
from TurnoConsultaExterna
where TurnoId = 8

update TurnoConsultaExterna
set asistido = 1
where TurnoId = 8

select fechahora
 from HorarioConsultaComun hcc
 where idHorarioComun
 not in(
 select tce.idHorarioComun
 from TurnoConsultaExterna tce, HorarioConsultaComun hf
 where(estado = 1)
 and (tce.idHorarioComun = hf.idHorarioComun))
 
 select fechahora
 from HorarioFisiokinesiologiaCE hcc
 where IdHorarioFisio 
 not in(
 Select tce.IdHorarioFisio
 from TurnoConsultaExterna tce, HorarioFisiokinesiologiaCE hf
 where(estado = 1)
 and (tce.idHorarioFisio = hf.idHorarioFisio))
 
 select fechahora
 from HorarioSaludMentalCE hcc
 where IdHorarioSM
 not in(
 Select tce.IdHorarioSM
 from TurnoConsultaExterna tce, HorarioSaludMentalCE hsm
 where(estado = 1)
 and (tce.idHorarioSm = hsm.idHorarioSM))
 
 /*PARA SABER CUAL MEDICO Y SALA ESTAN DISPONIBLES*/
 select ms.idSalaMedico, ms.idSala, ms.idMedico, e.nombre, e.apellido
 from medico m, empleado e, MedicoSala ms, sala s, (select ms.idSalaMedico, count(*) cantidad
							 from TurnoConsultaExterna tce, MedicoSala ms
							 where (tce.idSalaMedico = ms.idSalaMedico)
							 group by ms.idSalaMedico) subconsulta
 where (ms.idSala = s.idSala)
 and (ms.idSalaMedico = subconsulta.idSalaMedico)
 and (capacidad > subconsulta.cantidad)
 and (e.idEmpleado = m.idEmpleado)
 and (m.idMedico = ms.idMedico)
 limit 1

 select count(*)
 from medico m, empleado e
 where (m.idEmpleado = e.idEmpleado)
 and (documentacion= "35689578")
 
 select count(*) cantidad
 from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms, HorarioConsultaComun hcc
 where (m.idEmpleado = e.idEmpleado)
 and (ms.idMedico = m.idMedico)
 and (tce.idSalaMedico = ms.idSalaMedico)
 and (hcc.idHorarioComun = tce.idHorarioComun)
 and (e.documentacion= "39291018")
 and (TipoConsultaExterna = 1)
 and (MONTH(hcc.fechahora) = 1) 
 
 select count(*) cantidad
 from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms, HorarioConsultaComun hcc
 where (m.idEmpleado = e.idEmpleado)
 and (ms.idMedico = m.idMedico)
 and (tce.idSalaMedico = ms.idSalaMedico)
 and (hcc.idHorarioComun = tce.idHorarioComun)
 and (e.documentacion= "39291018") 
 and (tce.asistido = 1)
 and (TipoConsultaExterna = 1)
 and (MONTH(hcc.fechahora) = 1)

 
 select count(*) cantidad
 from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms, HorarioFisiokinesiologiaCE hf
 where (m.idEmpleado = e.idEmpleado)
 and (ms.idMedico = m.idMedico)
 and (tce.idSalaMedico = ms.idSalaMedico)
 and (hf.idHorarioFisio = tce.idHorarioFisio)
 and (e.documentacion= "40192809") 
 and (tce.asistido = 1)
 and (TipoConsultaExterna = 2)
 and (MONTH(hf.fechahora) = 1)

 select count(*) cantidad
 from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms, HorarioFisiokinesiologiaCE hf
 where (m.idEmpleado = e.idEmpleado)
 and (ms.idMedico = m.idMedico)
 and (tce.idSalaMedico = ms.idSalaMedico)
 and (hf.idHorarioFisio = tce.idHorarioFisio)
 and (e.documentacion= "40192809") 
 and (TipoConsultaExterna = 2)
 and (MONTH(hf.fechahora) = 1)
 
 
 select count(*)
 from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms, HorarioSaludMentalCE hsm
 where (m.idEmpleado = e.idEmpleado)
 and (ms.idMedico = m.idMedico)
 and (tce.idSalaMedico = ms.idSalaMedico)
 and (hsm.idHorarioSM = tce.idHorarioSM)
 and (e.documentacion= "40192809") 
 and (TipoConsultaExterna = 3)
 and (MONTH(hsm.fechahora) = 1)
  
 select count(*)
 from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms, HorarioSaludMentalCE hsm
 where (m.idEmpleado = e.idEmpleado)
 and (ms.idMedico = m.idMedico)
 and (tce.idSalaMedico = ms.idSalaMedico)
 and (hsm.idHorarioSM = tce.idHorarioSM)
 and (e.documentacion = "40192809") 
 and (tce.asistido = 1)
 and (TipoConsultaExterna = 3)
 and (MONTH(hsm.fechahora) = 1)
 
 
 select count(*)
 from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms
 where (m.idEmpleado = e.idEmpleado)
 and (ms.idMedico = m.idMedico)
 and (tce.idSalaMedico = ms.idSalaMedico)
 and (e.documentacion = "40192809")
 and (MONTH(hsm.fechahora) = 1)
 
 select documentacion
 from empleado e, medico m, medicosala ms
 where m.idempleado=e.idempleado
 and ms.idmedico=m.idmedico
 and idsalamedico=3
 
 insert into PlusHonorarioMedico values
 (1, curdate(), 2000)
 
 select ms.idSalaMedico, ms.idSala, ms.idMedico, e.nombre, e.apellido
  from medico m, empleado e, MedicoSala ms, sala s,   (select ms.idSalaMedico, count(*) cantidad 
													  from TurnoConsultaExterna tce, MedicoSala ms 
													  where(tce.idSalaMedico = MS.idSalaMedico) 
													  group by ms.idSalaMedico) subconsulta 
  where(MS.idSala = s.idSala) 
  and (ms.idSalaMedico = subconsulta.idSalaMedico) 
  and (capacidad > subconsulta.cantidad) 
  and (e.idEmpleado = m.idEmpleado) 
  and (m.idMedico = ms.idMedico)
  limit 1
  
  select idHorarioFisio from HorarioFisiokinesiologiaCE where (fechahora = '2018/01/01 10:45')
  
  select ms.idSalaMedico, ms.idSala, ms.idMedico, e.nombre, e.apellido 
  from medico m, empleado e, MedicoSala ms, sala s, (select ms.idSalaMedico, count(*) cantidad 
													from TurnoConsultaExterna tce, MedicoSala ms 
													where(tce.idSalaMedico = MS.idSalaMedico) 
													group by ms.idSalaMedico) subconsulta 
  where(MS.idSala = s.idSala) 
  and (ms.idSalaMedico = subconsulta.idSalaMedico) 
  and (capacidad > subconsulta.cantidad) 
  and (e.idEmpleado = m.idEmpleado) 
  and (m.idMedico = ms.idMedico) 
  limit 1
  
  select ms.idMedico, e.nombre, e.apellido 
  from medico m, empleado e, MedicoSala ms, sala s, (select ms.idSalaMedico, count(*) cantidad 
													from TurnoConsultaExterna tce, MedicoSala ms 
													where(tce.idSalaMedico = MS.idSalaMedico) 
													group by ms.idSalaMedico) subconsulta 
  where(MS.idSala = s.idSala) 
  and (ms.idSalaMedico = subconsulta.idSalaMedico) 
  and (capacidad > subconsulta.cantidad) 
  and (e.idEmpleado = m.idEmpleado) 
  and (m.idMedico = ms.idMedico)