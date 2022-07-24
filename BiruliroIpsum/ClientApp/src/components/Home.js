import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div>
                <h1>Birolipsum</h1>
                <p>
                    Birolipsum é um gerador de Lorem Ipsum com citações do (infelizmente) presidente do Brasil,
                    Jair Bolsonaro (ou Biroliro para os íntimos).
                </p>
                <label>Mas, antes de tudo, o que é Lorem Ipsum?</label>
                <p>
                    <span style={{ fontStyle: 'italic' }}>
                        "[...] lorem ipsum é um texto utilizado para preencher o espaço de texto em publicações (jornais, revistas, e sites)
                        e testar aspectos visuais (cores, fontes etc.), com a finalidade de verificar o layout, a tipografia e formatação antes de utilizar conteúdo real."
                        - <a target="blank" href="https://pt.wikipedia.org/wiki/Lorem_ipsum">Wikipédia</a>
                    </span>
                </p>
                <label>
                    E porque usar um lorem ipsum qualquer quando você pode militar com citações do presidente
                    enquanto faz seu trabalho???
                </label>
            </div >
        );
    }
}
