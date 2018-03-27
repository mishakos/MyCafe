import * as React from 'react';
import { Component } from 'react';
import { RouteComponentProps } from 'react-router';

type ClientProps = RouteComponentProps<{}>;

class Client extends Component<ClientProps, {}> {
    render() {
        return <div>
            <h3>Client component</h3>
        </div>;
    };
};

export default Client;