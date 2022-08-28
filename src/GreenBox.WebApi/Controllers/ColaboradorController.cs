using AutoMapper;
using GreenBox.Business.Interfaces;
using GreenBox.Business.Models;
using GreenBox.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GreenBox.WebApi.Controllers
{
    public class ColaboradorController : MainController
    {
        private readonly IColaboradorRepository _colaboradorRepository;
        private readonly IColaboradorService _colaboradorService;
        private readonly IMapper _mapper;
        public ColaboradorController(INotificador notificador,
                                     IMapper mapper,
                                     IColaboradorRepository colaboradorRepository,
                                     IColaboradorService colaboradorService) : base(notificador)
        {
            _mapper = mapper;
            _colaboradorRepository = colaboradorRepository;
            _colaboradorService = colaboradorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ColaboradorViewModel>>> ObterTodos()
        {
            return CustomResponse(_mapper.Map<IEnumerable<ColaboradorViewModel>>(await _colaboradorRepository.ObterTodos()));
        }

        [HttpGet("id:{guid}")]
        public async Task<ActionResult<ColaboradorViewModel>> ObterPorId(Guid id)
        {
            var colaborador = await _colaboradorRepository.ObterPorId(id);

            if (colaborador == null)
                return NotFound();


            return CustomResponse(_mapper.Map<ColaboradorViewModel>(colaborador));
        }
        [HttpPost]
        public async Task<ActionResult<ColaboradorViewModel>> Adicionar(ColaboradorViewModel colaboradorViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            await _colaboradorService.Adicionar(_mapper.Map<Colaborador>(colaboradorViewModel));

            return CustomResponse(colaboradorViewModel);
        }

        [HttpPut]
        public async Task<ActionResult<ColaboradorViewModel>> Atualizar(Guid id, ColaboradorViewModel colaboradorViewModel)
        {
            if (id != colaboradorViewModel.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse(colaboradorViewModel);
            }

            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            await _colaboradorService.Atualizar(_mapper.Map<Colaborador>(colaboradorViewModel));

            return CustomResponse(colaboradorViewModel);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ColaboradorViewModel>> Excluir(Guid id)
        {
            var colaborador = await _colaboradorRepository.ObterPorId(id);

            if (colaborador == null)
                return NotFound();

            await _colaboradorService.Remover(id);

            return CustomResponse(colaborador);
        }


    }
}
