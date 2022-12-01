using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi_Exercicio_2.DataModels;

namespace RestApi_Exercicio_2.Controllers
{
    [ApiController]
    [Route("api")]
    public class MatriculaController : ControllerBase
    {
        //retorna todas as matriculas...
        [HttpGet]
        [Route("matriculas")]
        public async Task<IActionResult> todasMatriculas([FromServices] Context context)
        {
            var matricula = await context.Matricula.AsNoTracking().ToListAsync();
                        
            return !matricula.Any() ? NotFound("Nenhuma matricula no sistema") : Ok(matricula);
        }

        //retorna um matricula especifico...
        [HttpGet]
        [Route("matricula/{id}")]
        public async Task<IActionResult> BuscarMatricula([FromServices] Context context, [FromRoute] int id)
        {
            var matricula = await context.Matricula.AsNoTracking().FirstOrDefaultAsync(m => m.id == id);
            return matricula == null ?
                NotFound($"Matricula com ID {id} não encontrada") :
                Ok(matricula);
        }

        //cadastrar matricula...
        [HttpPost]
        [Route("matricula/cadastrar")]
        public async Task<IActionResult> CadastrarMatricula([FromServices] Context context, [FromBody] Matricula matricula)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                await context.Matricula.AddAsync(matricula);
                await context.SaveChangesAsync();
                //return Created($"api/matriculas/{matricula.id}", matricula);
                return Created($"Matricula '{matricula.id}' realizada!", matricula);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao cadastrar a matricula {matricula.id}. Tente novamente mais tarde...");
            }
        }

        //atualizar matricula...
        [HttpPut]
        [Route("matricula/atualizar/{id}")]
        public async Task<IActionResult> AtualizarMatricula([FromServices] Context context, [FromBody] Matricula matricula, [FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest("Model inválida");

            var m = await context.Matricula.FirstOrDefaultAsync(m => m.id == id);

            if (m == null) return NotFound("Matricula não encontrada");

            try
            {
                m.data = matricula.data;
                m.idAluno = matricula.idAluno;
                m.idCurso = matricula.idCurso;

                context.Matricula.Update(m);
                await context.SaveChangesAsync();
                return Ok(m);
            }
            catch (Exception ex)
            {
                return BadRequest($"Falha ao atualizar a matricula {m.id}... Tente novamente mais tarde...");
            }
        }

        //excluir matricula
        [HttpDelete]
        [Route("matricula/excluir/{id}")]
        public async Task<IActionResult> ExcluirMatricula([FromServices] Context context, [FromRoute] int id)
        {
            var m = await context.Matricula.FirstOrDefaultAsync(m => m.id == id);

            if (m == null) return BadRequest($"Matricula {id} não encontrada");

            try
            {
                context.Matricula.Remove(m);
                await context.SaveChangesAsync();

                return Ok($"Matricula '{m.id}' excluída com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao excluir a matricula {m.id}...");
            }
        }

    }
}
