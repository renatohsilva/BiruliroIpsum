﻿using Microsoft.AspNetCore.Mvc;

namespace QuanticIpsum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] textArea = new[]
        {
            @"Olhe, meu amigo,
              Pegue a visão,
              Resolva seu B.O,
              Pois é, mas",
            @"se organize.
              falador passa mal, rapaz.
              você errou grandão.
              isso é muito grave.",
            @"O que você tá fazendo é
              Tá acontecendo aqui um movimento pra
              O que nós estamos vendo é um interesse seu de
              O Brasil tá vendo a sua atitude que na verdade serve pra
              Estão tentando reduzir a experiência da mulher fenotipicamente negra a um ato pra",
            @"promover a deslegitimação
              ofender as vulnerabilidades
              se aproveitar do discurso
              se apropriar
              tirar o contexto
              se aproveitar
              corromper as descontruções
              ressignificar inverdades
              criticar maliciosamente os princípios
              reduzir o discurso
              potencializar o silenciamento
              desrespeitar a jornada
              usurpar o lugar de fala
              desmobilizar os discursos
              prestar desacolhimento
              alvejar a militância
              desestabilizar as oportunidades
              estereotipizar a biologia
              diminutizar as lamúrias
              enfraquecer as conquistas
              transversalizar as palavras
              julgar o caráter
              fazer palco em cima
              deslegitimar a relativização
              assumir o lugar de fala da ancestralidade
              incentivar a erradicação
              desalinhar as pautas
              descentralizar as uniformidades do discurso
              abusar psicologicamente
              recusar internalizar as diversidades
              descontextualizar a argumentatividade",
            @"da comunidade LBTQIA+ no contexto civilizacional contemporâneo
              da reparação história há tanto tempo necessária
              dos pretos, pardos, miscigenados, indígenas e autoproclamados
              da mulher fenotipicamente negra
              das mulheres trans
              da homoafetividade
              de seus iguais, silenciados pela heteronormatividade patriarcal
              da luta anti-colonialista
              da mulher branca socialmente privilegiada, em detrimento da pauta antirracial
              do homem negro convocado ao desejo de se autosabotar
              das pautas minoritárias
              dos indivíduos silenciados por seus lugares de dores",
            @"para proveito próprio.
              de maneira a dizimar o discurso acolhedor.
              se aproveitando de uma pauta coletiva para resolver um B.O que é seu.
              com o intuitos egóicos que transcendem a normalidade dos fatos.
              sem entender as vicissitudes sociais que abrangem as minorias pobres e desprivilegiadas, que vivem à margem de uma sociedade cruel e opressora.
              sendo contraproducente com quem é diferente de você.
              infligindo sentimentos de dor na alma dos menos privilegiados.
              perpetuando o fascismo.
              dos gays e não-binários.
              para propagar inverdades.
              ressignificando a conversa com inverdades.
              cujos fenótipos nunca serão sobrepujados em detrimento dos negros.
              se aproveitando da apropriação cultural.
              fingindo não entender o contexto sócio-cultural."
        };



        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return string.Join(' ', textArea);
        }
    }
}