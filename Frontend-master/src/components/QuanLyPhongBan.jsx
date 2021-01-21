import React, { Component } from 'react'
export default class QuanLyPhongBan extends Component {
    constructor(props) {
        super(props);
        this.state = {
            trangThai: true

        }
    }
    myFunction = () => {
        alert("Your file is being uploaded!")
    }
    trangThaiSua = () => {

        if (this.state.trangThai) {
            this.setState({
                trangThai: !this.state.trangThai
            });
        }
    }
    trangThaiThemMoi = () => {

        if (!this.state.trangThai) {
            this.setState({
                trangThai: !this.state.trangThai
            });
        }
    }
    hienThiForm = () => {
        if (this.state.trangThai === true) {
            return (<div className="col-3">
                <div className="card text-center">
                    <div className="card-header">
                        <p className="disabled">Thêm mới</p>
                    </div>
                    <div className="card-body">
                        <div className="form-group">
                            <div className="form-group">
                                <p style={{ textAlign: 'left' }}>Mã phòng ban</p>
                                <input type="text" className="form-control" name id aria-describedby="helpId" placeholder="Mã phòng ban" />
                                <p style={{ textAlign: 'left' }}>Tên phòng ban</p>
                                <input type="text" className="form-control" name id aria-describedby="helpId" placeholder="Tên phòng ban" />
                                {/* <p style="text-align: left;">Quyền</p>
                  <select class="form-select form-control" aria-label="Default select example">
                      <option selected>Chọn quyền</option>
                      <option value="1">One</option>
                      <option value="2">Two</option>
                      <option value="3">Three</option>
                    </select>
              </div> */}
                                <input type="submit" className="btn btn-primary btn-block mt-2" value="Thêm mới" />

                            </div>
                        </div>
                    </div>
                </div>
            </div>);
        }
        else {
            return (<div className="col-3">
                <div className="card text-center">
                    <div className="card-header">
                        <p className="disabled">Sửa</p>
                    </div>
                    <div className="card-body">
                        <div className="form-group">
                            <div className="form-group">
                                <p style={{ textAlign: 'left' }}>Mã phòng ban</p>
                                <input type="text" className="form-control" name id aria-describedby="helpId" placeholder="Mã phòng ban" />
                                <p style={{ textAlign: 'left' }}>Tên phòng ban</p>
                                <input type="text" className="form-control" name id aria-describedby="helpId" placeholder="Tên phòng ban" />
                                {/* <p style="text-align: left;">Quyền</p>
              <select class="form-select form-control" aria-label="Default select example">
                  <option selected>Chọn quyền</option>
                  <option value="1">One</option>
                  <option value="2">Two</option>
                  <option value="3">Three</option>
                </select>
          </div> */}
                                <input type="submit" className="btn btn-primary btn-block mt-2" value="Sửa" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>);
        }
    }
    render() {
        return (
            <div className="col-9">
                <h1>Chức năng Quản lý phòng ban</h1>
                <div className="btn-group">
                    <div className="form-group">
                        <input type="text" name id className="form-control" placeholder="Nhập tên" />
                    </div>
                    <div className="btn btn-primary ml-1">Tìm kiếm</div>
                    <div className="btn btn-primary themmoi mt-1" onClick={() => this.trangThaiThemMoi()}>Thêm mới</div>

                </div>

                <div className="row">
                    <div className="col-9">
                        <table className="table table-striped table-hover">
                            <thead>
                                <tr>
                                    <th>STT</th>
                                    <th>Mã phòng ban</th>
                                    <th>Tên phòng ban</th>
                                    {/* <th>Quyền</th> */}
                                    <th>Thao tác</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>{this.props.stt}</td>
                                    <td>{this.props.maPhongBan}</td>
                                    <td>{this.props.tenPhongBan}</td>
                                    {/* <td>admin</td> */}
                                    <td>
                                        <div className="btn btn-warning btn-group" onClick={() => this.trangThaiSua()} style={{ fontSize: "22px" }}>
                                            <div className="fa fa-edit">Sửa</div>
                                        </div>
                                        <div className="btn btn-danger btn-group ml-2" style={{ fontSize: "22px" }}>
                                            <div className="fa fa-edit">Xóa</div>
                                        </div>
                                    </td>
                                </tr>

                                {/* copy tr vào đây */}
                            </tbody>
                        </table>
                    </div>
                    {/* hiển thị form */}
                    {this.hienThiForm()}
                </div>
            </div>

        )
    }
}
