import React, { Component } from 'react'
import { Alert, AlertContainer } from "react-bs-notifier";
class AlertComponent extends Component {
    render() {
        return (
            <AlertContainer>
                <Alert type="info">Thông báo</Alert>
            </AlertContainer>
        );
    }
}

export default AlertComponent;