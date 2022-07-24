import React, { Component } from 'react';
import { Row, Col } from 'reactstrap';
import './GerarMitadas.css';

export class GerarMitadas extends Component {
    static displayName = GerarMitadas.name;
    static size = 500;

    constructor(props) {
        super(props);
        this.state = { listaDeMitadas: "", numeroParagrafos: 1, imagemDoMito: "", paginaPopulada: false };
        this.numeroParagrafosMudou = this.numeroParagrafosMudou.bind(this);
        this.buscarMitadas = this.buscarMitadas.bind(this);
    }

    buscarMitadas() {
        this.popularPagina();
    }

    numeroParagrafosMudou(event) {
        this.setState({ numeroParagrafos: event.target.value });
    }

    render() {
        return (
            <div>
                <h1>Biruliro Ipsum</h1>
                <Row>
                    <Col md="6">
                        <label className="labelTitulo" htmlFor="paragraphsNumber">Quantos parágrafos de mitadas você quer?</label>
                        <div className="paragraphCounter">
                            <input type="range"
                                id="numeroDeParagrafos"
                                placeholder="Parágrafo"
                                name="paragrafo"
                                min="1"
                                max="15"
                                value={this.state.numeroParagrafos}
                                onChange={this.numeroParagrafosMudou} />
                            <input type="number"
                                id="paragraphsNumber"
                                min="1"
                                max="15"
                                value={this.state.numeroParagrafos} readOnly />
                            <button className="btn btn-success"
                                onClick={this.buscarMitadas}>Mitar</button>
                        </div>
                    </Col>
                    <Col md="6" justify="flex-end">
                        {this.state.paginaPopulada ?
                                (<img src={this.state.imagemDoMito}
                                    className="faceMito"
                                    width="180"
                                    height="180" />) : ("")}
                    </Col>
                </Row>
                <Row>
                    <div>
                        <Col md="12">
                            <textarea value={this.state.listaDeMitadas}
                                rows={15}
                                readOnly={true} />
                        </Col>

                        <label>Jair Biroliro Bolsonaro</label>
                    </div >
                </Row>
            </div >
        );
    }

    async popularPagina() {
        const encodedNumeroParagrafos = encodeURIComponent(this.state.numeroParagrafos);
        const response = await fetch(`mitadas?numeroParagrafos=${encodedNumeroParagrafos}`);
        const mitada = await response.json();

        let listaDeMitadas = Array.from(mitada.listaDeMitadas).join('\n\n');
        let imagemDoMito = mitada.imagemDoMito;

        this.setState({ listaDeMitadas: listaDeMitadas, imagemDoMito: imagemDoMito, paginaPopulada: true });
    }
}
