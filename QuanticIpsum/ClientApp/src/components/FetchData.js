import React, { Component } from 'react';
import { Row, Col } from 'reactstrap';

export class FetchData extends Component {
    static displayName = FetchData.name;

    constructor(props) {
        super(props);
        this.state = { textAreaValue: "", };
        this.makeLeroLero = this.makeLeroLero.bind(this);
    }

    makeLeroLero() {
        this.populateLeroLeo();
    }

    render() {
        return (
            <div>
                <h1>Lero-Lero Quantico</h1>
                <Row>
                    <Col xs="12">
                        <label>{this.state.textAreaValue}</label>
                    </Col>
                </Row>
                <Row>
                    <Col xs="4">
                        <button className="btn btn-primary ml-5 ml-lg-0" onClick={this.makeLeroLero}>Desconstruir</button>
                    </Col>
                </Row>
            </div>
        );
    }

    async populateLeroLeo() {
        const response = await fetch('weatherforecast');
        const data = await response.text();
        this.setState({ textAreaValue: data, loading: false });
    }
}
